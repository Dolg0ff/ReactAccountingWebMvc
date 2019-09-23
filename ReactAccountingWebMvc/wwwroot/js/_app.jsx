class Account extends React.Component {

    constructor(props) {
        super(props);
        this.state = { data: props.account };
        this.onClick = this.onClick.bind(this);
    }
    onClick(e) {
        this.props.onRemove(this.state.data);
    }
    render() {
        return <div>
            <p><b>{this.state.data.name}</b></p>
            <p>Count {this.state.data.count}</p>
            <p><button onClick={this.onClick}>Удалить</button></p>
        </div>;
    }
}

class AccountForm extends React.Component {

    constructor(props) {
        super(props);
        this.state = { name: "", count: 0 };

        this.onSubmit = this.onSubmit.bind(this);
        this.onNameChange = this.onNameChange.bind(this);
        this.onCountChange = this.onCountChange.bind(this);
    }
    onNameChange(e) {
        this.setState({ name: e.target.value });
    }
    onCountChange(e) {
        this.setState({ count: e.target.value });
    }
    onSubmit(e) {
        e.preventDefault();
        var accountName = this.state.name.trim();
        var accountCount = this.state.count;
        if (!accountName || accountCount <= 0) {
            return;
        }
        this.props.onAccountSubmit({ name: accountName, price: accountCount });
        this.setState({ name: "", count: 0 });
    }
    render() {
        return (
            <form onSubmit={this.onSubmit}>
                <p>
                    <input type="text"
                        placeholder="Account"
                        value={this.state.name}
                        onChange={this.onNameChange} />
                </p>
                <p>
                    <input type="number"
                        placeholder="Count"
                        value={this.state.count}
                        onChange={this.onCountChange} />
                </p>
                <input type="submit" value="Сохранить" />
            </form>
        );
    }
}


class Accounts extends React.Component {

    constructor(props) {
        super(props);
        this.state = { accounts: [] };

        this.onAddAccount = this.onAddAccount.bind(this);
        this.onRemoveAccount = this.onRemoveAccount.bind(this);
    }
    // загрузка данных
    loadData() {
        var xhr = new XMLHttpRequest();
        xhr.open("get", this.props.apiUrl, true);
        xhr.onload = function () {
            var data = JSON.parse(xhr.responseText);
            this.setState({ account: data });
        }.bind(this);
        xhr.send();
    }
    componentDidMount() {
        this.loadData();
    }
    // добавление объекта
    onAddAccount(account) {
        if (account) {

            var data = JSON.stringify({ "name": account.name, "count": account.count });
            var xhr = new XMLHttpRequest();

            xhr.open("add", this.props.apiUrl, true);
            xhr.setRequestHeader("Content-type", "application/json");
            xhr.onload = function () {
                if (xhr.status == 200) {
                    this.loadData();
                }
            }.bind(this);
            xhr.send(data);
        }
    }
    // удаление объекта
    onRemoveAccount(account) {

        if (account) {
            var url = this.props.apiUrl + "/" + account.id;

            var xhr = new XMLHttpRequest();
            xhr.open("delete", url, true);
            xhr.setRequestHeader("Content-Type", "application/json");
            xhr.onload = function () {
                if (xhr.status == 200) {
                    this.loadData();
                }
            }.bind(this);
            xhr.send();
        }
    }
    render() {

        var remove = this.onRemoveAccount;
        return <div>
            <AccountForm onAccountSubmit={this.onAddAccount} />
            <h2>Accounts</h2>
            <div>
                {
                    this.state.accounts.map(function (account) {

                        return <account key={account.id} account={account} onRemove={remove} />
                    })
                }
            </div>
        </div>;
    }
}

ReactDOM.render(
    <Accounts apiUrl="/api/accounts" />,
    document.getElementById("content")
);