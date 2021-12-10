import React from 'react';

import { Link } from 'react-router-dom';

import * as S from './styles';

const MainHeader = () => {
  return (
    <S.Container>
      <nav>
        <ul>
          <li>
            <Link to="/signIn">Home</Link>
          </li>
        </ul>
      </nav>
      <nav>
        <ul>
          <li>
            <Link to="/signIn">Sign-In</Link>
          </li>
        </ul>
      </nav>
      <nav>
        <ul>
          <li>
            <Link to="/signUp">Sign-Up</Link>
          </li>
        </ul>
      </nav>
    </S.Container>
  );
};

export default MainHeader;
