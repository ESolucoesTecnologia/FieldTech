
function Input({type, text, name, placeholder, handleOnChange, value}){

    return (
        <>
            <label htmlFor={name}>{text}:</label>
            <input type={type} 
                    name={name} 
                    id={name} 
                    placeholder={placeholder} 
                    onChange={handleOnChange}
                    value={value}>
            </input>
        </>
    )
}

export default Input