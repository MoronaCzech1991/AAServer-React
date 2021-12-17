import React from 'react';
import { Route, Redirect } from 'react-router-dom';

import { isLogged } from '../../api/auth';

const PrivateRoute = (props: any) =>
  isLogged() ? <Route {...props} /> : <Redirect to="/signIn" />;

export default PrivateRoute;
