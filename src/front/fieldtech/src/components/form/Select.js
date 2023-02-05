

function Select({text, name, options, handleOnChange, value}){
    return (
        <div>
            <label htmlFor={name}>{text}:</label>
            <select name={name} id={name}>
                <option>Selecione</option>
            </select>
        </div>
    )
}

export default Select
