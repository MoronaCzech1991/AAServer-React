import React from 'react';
import * as S from './styles';

import MainHeader from '../components/mainHeader';
import Content from '../components/content/index';
import Footer from '../components/footer';

import { Router } from 'react-router-dom';

import { history } from '../pages/history';

const App = () => {
  return (
    <Router history={history}>
      <S.Container>
        <MainHeader />
        <Content />
        <Footer />
      </S.Container>
    </Router>
  );
};

export default App;
