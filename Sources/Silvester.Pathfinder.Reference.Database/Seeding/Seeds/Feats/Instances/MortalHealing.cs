using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MortalHealing : Template
    {
        public static readonly Guid ID = Guid.Parse("d2f1a629-a53a-46cd-9a6a-8f450d670877");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Mortal Healing",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d7108499-d955-46cd-af31-d53f10c87a4c"), Type = TextBlockType.Text, Text = "You grant greater healing when the gods don’t interfere. When you roll a success to (Action: Treat Wounds) for a creature that hasn’t regained Hit Points from divine magic in the past 24 hours, you get a critical success on your check instead and restore the corresponding amount of Hit Points." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("224efb21-d32c-4677-bd93-65afaefd75c7"), Feats.Instances.GodlessHealing.ID);
            builder.FollowSpecificPhilosophy(Guid.Parse("64ee5f55-d1b8-4b94-aad6-99098e2c15b0"), Philosophies.Instances.LawsOfMortality.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("ca0dbc5e-ee30-4bd6-bae6-92e3c08674b8"),
                SourceId = Sources.Instances.LostOmensGodsAndMagic.ID,
                Page = -1
            };
        }
    }
}
