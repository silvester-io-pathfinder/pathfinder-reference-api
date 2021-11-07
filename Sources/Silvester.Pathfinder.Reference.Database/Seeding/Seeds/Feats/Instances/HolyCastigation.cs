using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class HolyCastigation : Template
    {
        public static readonly Guid ID = Guid.Parse("5107ff48-a415-471d-ade8-e559e81ed400");

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
            yield return new TextBlock { Id = Guid.Parse("7a132b61-40cf-402e-a9fd-977b03058d56"), Type = TextBlockType.Text, Text = "You combine holy energy with positive energy to damage demons, devils, and their evil ilk. (spell: Heal) spells you cast damage fiends as though they were undead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("6ac55781-a159-4127-8272-9d9635d6924d"), or => 
            {
                or.HaveSpecificAlignment(Guid.Parse("6d9d7fb6-3e93-4231-934c-8349ea7710b5"), Alignments.Instances.LawfulGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("6e5b7d0e-8da2-4bd8-85aa-bf48e476167b"), Alignments.Instances.ChaoticGood.ID);
                or.HaveSpecificAlignment(Guid.Parse("be699776-70cf-4827-a8ec-1ef2391e0567"), Alignments.Instances.NeutralGood.ID);
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
                Id = Guid.Parse("d6125571-6c77-403f-9445-157e7dd10b2d"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
