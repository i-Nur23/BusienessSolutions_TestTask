import { Route, Routes } from 'react-router-dom'
import Layout from './components/Layout'
import Balances from './pages/balances/Balances'
import { ClientCreate, ClientEdit, Clients, ClientsArchive } from './pages/clients'
import { ReceiptCreate, ReceiptEdit, Receipts } from './pages/receipts'
import { ResourceCreate, ResourceEdit, Resources, ResourcesArchive } from './pages/resources'
import { ShipmentCreate, ShipmentEdit, Shipments } from './pages/shipments'
import { Units, UnitCreate, UnitEdit, UnitsArchive } from './pages/units'
import 'bootstrap/dist/css/bootstrap.min.css';

function App() {
  return (
    <Routes>
      <Route path='/' element={<Layout/>}>
        <Route index path='balances' element={ <Balances/> } />
        <Route path='clients'>
          <Route index element={ <Clients/> } />
          <Route path='archive' element={ <ClientsArchive/> } />
          <Route path='edit/:id' element={ <ClientEdit/> } />
          <Route path='create' element={ <ClientCreate/> } />
        </Route>
        <Route path='receipts'>
          <Route index element={ <Receipts/> } />
          <Route path='edit/:id' element={ <ReceiptEdit/> } />
          <Route path='create' element={ <ReceiptCreate/> } />
        </Route>
        <Route path='resources'>
          <Route index element={ <Resources/> } />
          <Route path='archive' element={ <ResourcesArchive/> } />
          <Route path='edit/:id' element={ <ResourceEdit/> } />
          <Route path='create' element={ <ResourceCreate/> } />
        </Route>
        <Route path='shipments'>
          <Route index element={ <Shipments/> } />
          <Route path='edit/:id' element={ <ShipmentEdit/> } />
          <Route path='create' element={ <ShipmentCreate/> } />
        </Route>
        <Route path='units'>
          <Route index element={ <Units/> } />
          <Route path='archive' element={ <UnitsArchive/> } />
          <Route path='edit/:id' element={ <UnitEdit/> } />
          <Route path='create' element={ <UnitCreate/> } />
        </Route>
      </Route>
    </Routes>
  )
}

export default App
