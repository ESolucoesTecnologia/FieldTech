import { BrowserRouter as Router, Route, Routes } from 'react-router-dom'
import Home from './components/pages/Home'
import Empresa from './components/pages/Empresa'
import Contato from './components/pages/Contato'
import NavBar from './components/layout/NavBar'
import Footer from './components/layout/Footer'


import Container from './components/layout/Container'


function App() {


  return (
    <Router>
      <NavBar></NavBar>
      <Container customClass="min-height">
      
      <Routes>
        <Route exact path="/" element={<Home/>}></Route>
        <Route path="/empresa" element={<Empresa/>}></Route>
        <Route path="/contato" element={<Contato/>}></Route>
      </Routes>      
      </Container>
      <Footer></Footer>
    </Router>
  )
}

export default App;
