using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DistractingSpellstrike : Template
    {
        public static readonly Guid ID = Guid.Parse("0533a38b-4e8e-41f1-b27c-cb7e7dbd8b63");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Distracting Spellstrike",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("863f23f6-54bd-49a2-9e50-0b6f0a2deac0"), Type = TextBlockType.Text, Text = "You weave distracting magic with one hand to enhance your (feat: Spellstrike). Make a (feat: Spellstrike) and (action: Feint) against the target of your (action: Strike). Do this immediately before making the (action: Strike), but after choosing your target. The (action: Feint) gains the (trait: arcane), (trait: illusion), and (trait: visual) traits, and it always has the basic effects of a (action: Feint), rather than applying any adjustments or alternate effects from other feats or abilities." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHybridStudy(Guid.Parse("f3f6513c-0ff5-454c-9791-d6e32943e18f"), HybridStudies.Instances.LaughingShadow.ID);
            builder.HaveSpecificFeat(Guid.Parse("8dc269e4-8ea5-4976-ad82-b1b4786d8851"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("50e0435a-0fc3-4857-a98d-eb05d878888d"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
