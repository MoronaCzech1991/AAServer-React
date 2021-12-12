import React from 'react';

import { Switch, Route } from 'react-router-dom';

import * as S from './styles';

import SignIn from '../signIn';
import SignUp from '../signUp';

const Content = () => {
  return (
    <S.Container>
      <Switch>
        <Route exact path="/signin">
          <SignIn />
        </Route>
        <Route exact path="/signup">
          <SignUp />
          <SignUp />
          <SignUp />
          <SignUp />
          <SignUp />
        </Route>
      </Switch>
    </S.Container>
  );
};

export default Content;
