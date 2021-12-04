import React from 'react';

import * as S from './styles';

import SignIn from '../components/signin';
import Header from '../components/header/index';

const App = () => {
  return (
    <S.Container>
      <Header />
      <SignIn />
    </S.Container>
  );
};

export default App;
