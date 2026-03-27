import React from 'react';
// import { isAutenticated } from '../api/auth';

import { Switch, Route } from 'react-router-dom';

import SignIn from '../pages/signIn';
import SignUp from '../pages/signUp';
import Home from '../pages/home';
import NotFound from '../pages/notFound/index';
import PrivateRoute from '../components/privateRoute/index';

const Routes = () => (
  <Switch>
    <PrivateRoute component={Home} exact path="/"></PrivateRoute>
    <Route component={SignIn} exact path="/signin"></Route>
    <Route component={SignUp} exact path="/signup"></Route>
    <Route component={NotFound} />
  </Switch>
);

export default Routes;
