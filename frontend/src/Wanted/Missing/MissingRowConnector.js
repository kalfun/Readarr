import { connect } from 'react-redux';
import { createSelector } from 'reselect';
import createAuthorSelector from 'Store/Selectors/createAuthorSelector';
import MissingRow from './MissingRow';

function createMapStateToProps() {
  return createSelector(
    createAuthorSelector(),
    (author) => {
      return {
        author
      };
    }
  );
}

export default connect(createMapStateToProps)(MissingRow);
