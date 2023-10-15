#### **Little test setup**
`List of IApplicantModel` <br>
-> StaffModel <br>
-> ManagerModel <br>
-> ExecutiveModel <br>

#### **Basis**
`IApplicantModel` -> Outsider interface with basic props / func (type: IAccounts) to turn applicant into employee

#### **Create diffrent types**
`StaffModel     : IApplicantModel` -> Implements interface 1 to 1 | type IAccount (new Account) <br>
`ManagerModel   : IApplicantModel` -> Implements interface 1 to 1 | type IAccount (new ManagerAccount) <br>
`ExecutiveModel : IApplicantModel` -> Implements interface 1 to 1 | type IAccount (new ExecutiveAccount) <br>

#### **2 insider base models**
`EmployeeModel` -> FinalModel with all according props and funcs <br>
`IAccount` -> Function: Return EmployeeModel (final product) | Input IApplicantModel (conversion product) <br>

#### **Account types implementations**
`StaffAccount     : IAccount` -> Fill the final product with conversion product's values + accountType specific values <br>
`ManagerAccount   : IAccount` -> Fill the final product with conversion product's values + accountType specific values <br>
`ExecutiveAccount : IAccount` -> Fill the final product with conversion product's values + accountType specific values <br>
