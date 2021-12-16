import React from 'react';
// import { isAutenticated } from '../api/auth';

import { Switch, Route } from 'react-router-dom';

import SignIn from '../pages/signIn';
import SignUp from '../pages/signUp';
import Home from '../pages/home';

const Routes = () => (
  <Switch>
    <Route component={Home} exact path="/"></Route>
    <Route component={SignIn} path="/signin"></Route>
    <Route component={SignUp} path="/signup"></Route>
  </Switch>
);

export default Routes;
