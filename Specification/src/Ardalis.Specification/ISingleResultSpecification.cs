﻿namespace Ardalis.Specification
{
  /// <summary>
  /// A marker interface for specifications that are meant to return a single entity. Used to constrain methods
  /// that accept a Specification and return a single result rather than a collection of results.
  /// </summary>
  public interface ISingleResultSpecification
  {
  }

  /// <summary>
  /// A marker interface for specifications that are meant to return a single entity. Used to constrain methods
  /// that accept a Specification and return a single result rather than a collection of results.
  /// </summary>
  public interface ISingleResultSpecification<T> : ISpecification<T>, ISingleResultSpecification
  {
  }

  /// <summary>
  /// A marker interface for specifications that are meant to return a single entity. Used to constrain methods
  /// that accept a Specification and return a single result rather than a collection of results.
  /// </summary>
  public interface ISingleResultSpecification<T, TResult> : ISpecification<T, TResult>, ISingleResultSpecification
  {
  }
}
