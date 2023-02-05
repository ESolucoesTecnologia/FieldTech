import Input from '../form/Input'

function FieldForm(){
    return (
        <form>
            <Input  type="text" 
                    text="Nome do técnico" 
                    name="name" 
                    placeholder="Nome do técnico">                    
            </Input>
        </form>


    )
}

export default FieldForm


