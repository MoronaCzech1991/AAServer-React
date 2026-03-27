import styled from 'styled-components';

export const Container = styled.div`
  background-color: #2d2926;
  color: #f2f1f0;
  min-height: 65px;
  min-width: 600px;
  width: 100%;
  box-shadow: 5px 5px 10px grey;
  display: flex;
  justify-content: end;
  align-items: center;
`;

export const Nav = styled.nav`
  background: #f2f1f0;
  color: #2d2926;
  margin: 0;
  padding: 10px;
  min-height: 25px;
  display: flex;
  align-items: center;
  :hover {
    background-color: #d7d2cb;
    transition: all 0.5s ease;
`;

export const Ul = styled.ul`
  list-style-type: none;
`;

export const Li = styled.li`
  > a {
    margin: 0;
    color: #2d2926;
    text-decoration: none;
  }
`;
