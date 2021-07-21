import React from 'react';

class AzDO extends React.Component {
    constructor(props) {
        super(props);
        this.state = { azitems: [] };
        this.handleFetchData = this.handleFetchData.bind(this);
    }

    handleFetchData(source, e) {

        e.preventDefault()
        console.log(source)
        fetch("https://localhost:5001/api/Metadatas")
            .then(res => res.json())
            .then(
                (result) => {
                    this.setState({
                        azitems: result
                    });
                    console.log(this.state.azitems.length)
                }
            );
    }

    render() {
        return (<div>
            <h2>AzDO data ...</h2><button onClick={(e) => this.handleFetchData("click", e)}>fetch data</button>
            <table>
                <thead>
                    <tr>
                        <th>ID</th>
                        <th>Build Count</th>
                        <th>Issue Count</th>
                    </tr>
                </thead>
                <tbody>
                    {this.state.azitems.map(emp => (
                        <tr key={emp.id}>
                            <td>{emp.id}</td>
                            <td>{emp.buildCount}</td>
                            <td>{emp.filedIssueCount}</td>
                        </tr>
                    ))}
                </tbody>
            </table>
            {this.state.AzItems}
        </div>);
    }
}

export default AzDO;