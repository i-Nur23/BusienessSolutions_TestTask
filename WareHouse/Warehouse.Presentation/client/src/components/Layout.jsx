import { Outlet } from 'react-router-dom'
import Container from 'react-bootstrap/Container';
import Nav from 'react-bootstrap/Nav';
import Navbar from 'react-bootstrap/Navbar';
import NavDropdown from 'react-bootstrap/NavDropdown';

export default function Layout() {
  return(
    <div className='w-100'>
    <Navbar sticky='top' expand="lg" className="w-100 absolute">
        <Container>
          <Navbar.Toggle aria-controls="basic-navbar-nav" />
          <Navbar.Collapse id="basic-navbar-nav">
            <Nav className="me-auto">
              <NavDropdown title="Склад" id="basic-nav-dropdown">
                <NavDropdown.Item href="/balances">Баланс</NavDropdown.Item>
                <NavDropdown.Item href="/receipts">Поступления</NavDropdown.Item>
                <NavDropdown.Item href="/shipments">Отгрузки</NavDropdown.Item>
              </NavDropdown>
              <NavDropdown title="Справочники" id="basic-nav-dropdown">
                <NavDropdown.Item href="/clients">Клиенты</NavDropdown.Item>
                <NavDropdown.Item href="/units">Единицы измерения</NavDropdown.Item>
                <NavDropdown.Item href="/resources">Ресурсы</NavDropdown.Item>
              </NavDropdown>
            </Nav>
          </Navbar.Collapse>
        </Container>
      </Navbar>
      <main style={{ padding: '1rem' }}>
        <Outlet />
      </main>
    </div>
  )
}