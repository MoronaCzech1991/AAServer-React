import React from 'react';
import * as S from './styles';

import { Link } from 'react-router-dom';

const MainHeader = () => {
  return (
    <S.Container>
      <nav>
        <ul>
          <li>
            <Link to="/">Home</Link>
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
