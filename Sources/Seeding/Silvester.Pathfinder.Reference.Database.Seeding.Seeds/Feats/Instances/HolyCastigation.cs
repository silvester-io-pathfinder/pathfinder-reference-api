using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HolyCastigation : Template
    {
        public static readonly Guid ID = Guid.Parse("94d556a0-5b56-4ce2-be6a-144ba29de284");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Holy Castigation",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("e16568f5-20c7-46d0-a203-e7f5ceb3cd8e"), Type = TextBlockType.Text, Text = $"You combine holy energy with positive energy to damage demons, devils, and their evil ilk. {ToMarkdownLink<Models.Entities.Spell>("Heal", Spells.Instances.Heal.ID)} spells you cast damage fiends as though they were undead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("3e5bfb5d-acc8-49d0-acfb-0e3db98f310f"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("04417936-0b6c-44f7-9699-a104dd9fd0a2"), Alignments.Instances.LawfulGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("d248e3fc-350c-48ec-9038-2eac7e1a1a53"), Alignments.Instances.ChaoticGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("215bf0d2-d5ec-4720-830d-4e301fe2bc88"), Alignments.Instances.NeutralGood.ID);
            });
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4cc15e71-96bd-4642-a606-609d16342fba"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
