import styles from './Select.module.css'
function Select({text, name, options, handleOnChange, value}){
    return (
        <>
            <label htmlFor={name}>{text}:</label>
            <select name={name} id={name} >
                <option className={styles.form_control}>Selecione</option>
                {options.map((option) => (
                    <option value={option.sigla} key={option.sigla}>{option.nome}-{option.sigla}</option>
                ))}
            </select>
        </>
    )
}

export default Select
