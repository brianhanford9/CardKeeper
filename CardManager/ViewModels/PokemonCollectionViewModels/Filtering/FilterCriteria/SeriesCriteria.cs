﻿using CardManager.Models.Cards.PokemonCards;
using CardManager.ViewModels.UtilityViewModels.Filtering.FilterEvaluations;

namespace CardManager.ViewModels.PokemonCollectionViewModels.Filtering.FilterCriteria;

public interface ISeriesCriteria : IFilterCriteria { }
public class SeriesCriteria : BaseFilterCriteria, ISeriesCriteria
{
    public override string Name { get; } = "Series";

    public override FilterCriteriaType Type { get; } = FilterCriteriaType.Collection;

    public override IReadOnlyList<IFilterEvaluationViewModel> Evaluations { get; } = [
        new EnumWithinEvaluation<PokemonSeries>(),
        ];
}
