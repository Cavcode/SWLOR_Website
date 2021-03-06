﻿using FluentValidation;
using SWLOR.Web.Models.UI.QuestEditor;

namespace SWLOR.Web.Models.Validation
{
    public class QuestDetailsUIValidator: AbstractValidator<QuestDetailsUI>
    {
        public QuestDetailsUIValidator()
        {
            RuleFor(x => x.QuestID)
                .NotNull()
                .GreaterThanOrEqualTo(-1);

            RuleFor(x => x.Name)
                .NotNull()
                .NotEmpty()
                .MaximumLength(100);

            RuleFor(x => x.JournalTag)
                .NotNull()
                .NotEmpty()
                .MaximumLength(32);

            RuleFor(x => x.FameRegionID)
                .NotNull()
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.RequiredFameAmount)
                .NotNull()
                .GreaterThanOrEqualTo(0);

            RuleFor(x => x.AllowRewardSelection)
                .NotNull();

            RuleFor(x => x.IsRepeatable)
                .NotNull();

            RuleFor(x => x.MapNoteTag)
                .NotNull()
                .MaximumLength(32);

            RuleFor(x => x.StartKeyItemID)
                .NotNull()
                .NotEmpty()
                .GreaterThanOrEqualTo(-1);

            RuleFor(x => x.RemoveStartKeyItemAfterCompletion)
                .NotNull();

            RuleFor(x => x.OnAcceptRule)
                .MaximumLength(32);
            
            RuleFor(x => x.OnAdvanceRule)
                .MaximumLength(32);
            
            RuleFor(x => x.OnCompleteRule)
                .MaximumLength(32);

            RuleFor(x => x.OnKillTargetRule)
                .MaximumLength(32);

            RuleFor(x => x.OnAcceptArgs)
                .MaximumLength(256);

            RuleFor(x => x.OnAdvanceArgs)
                .MaximumLength(256);

            RuleFor(x => x.OnCompleteArgs)
                .MaximumLength(256);

            RuleFor(x => x.OnKillTargetArgs)
                .MaximumLength(256);

            RuleForEach(x => x.PrerequisiteQuestIDs)
                .NotNull()
                .NotEmpty()
                .GreaterThanOrEqualTo(1);

            RuleFor(x => x.Rewards)
                .SetValidator(new QuestRewardsUIValidator());

            RuleForEach(x => x.QuestStates)
                .SetValidator(new QuestStateUIValidator());
        }
    }
}
