using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class OverwhelmingSpellstrike : Template
    {
        public static readonly Guid ID = Guid.Parse("80f13e5e-2b4a-4390-ab52-4a23b62b0eb8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Overwhelming Spellstrike",
                Level = 12,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a8644719-4732-4380-a92d-110286c6b47c"), Type = TextBlockType.Text, Text = "You pierce through your foe’s resistance. Make a (feat: Spellstrike). The spell you cast as part of the (feat: Spellstrike) ignores an amount of the target’s resistance to acid, cold, electricity, fire, or sonic damage equal to your level. This applies to all damage the spell deals, including persistent damage and damage caused by an ongoing effect of the spell. A creature’s immunities are unaffected." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("ac25c9f7-5390-46f1-bd2c-1a18f65ca957"), Feats.Instances.Spellstrike.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f7d2a47b-2e66-4152-99d7-7075853addfb"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
