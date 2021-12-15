import React from 'react';
// import { isAutenticated } from '../api/auth';

import { Switch, Route } from 'react-router-dom';

import SignIn from '../pages/signIn';
import SignUp from '../pages/signUp';
import Home from '../pages/home';

const Routes = () => (
  <Switch>
    <Route exact path="/">
      <Home />
    </Route>
    <Route path="/signin">
      <SignIn />
    </Route>
    <Route path="/signup">
      <SignUp />
    </Route>
  </Switch>
);

export default Routes;
