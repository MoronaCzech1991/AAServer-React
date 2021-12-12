import React from 'react';

import { BrowserRouter as Router } from 'react-router-dom';

import * as S from './styles';

import MainHeader from '../components/mainHeader/index';
import Content from '../components/content/index';
import Footer from '../components/footer';

const App = () => {
  return (
    <S.Container>
      <Router>
        <MainHeader />
        <Content />
        <Footer />
      </Router>
    </S.Container>
  );
};

export default App;
