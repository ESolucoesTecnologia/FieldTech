import { useEffect, useState } from 'react'
import styles from '../field/FieldForm.module.css'
import Input from '../form/Input'
import Select from '../form/Select'
import SubmitButton from '../form/SubmitButton'

function FieldForm({btnText}){
    const[ufs,setUfs] = useState([])

    useEffect(()=> {
        fetch('http://localhost:5000/uf',{
            method: 'GET',
            headers: {
                'Content-Type' : 'application/json',
            },
        })
            .then((resp) => resp.json())
            .then((data) => {
                setUfs(data)
            })
            .catch((err) => console.log(err))
    }, [])

    return (        
        <form className={styles.form}>
            <div>
            <Input  type="text" 
                    text="Nome do técnico" 
                    name="name" 
                    placeholder="Nome do técnico">                    
            </Input>           
            </div>
            <div>
            <Input  type="text" 
                    text="Email" 
                    name="name" 
                    placeholder="E-mail">                    
            </Input>
            </div>
            <div>
            <Select name="estado" text="Estado" options={ufs}></Select>
            <Input  type="text" 
                    text="Cidade" 
                    name="name" 
                    placeholder="Cidade">                    
            </Input>
            </div>
            <SubmitButton text="Salvar"></SubmitButton>
        </form>


    )
}

export default FieldForm


