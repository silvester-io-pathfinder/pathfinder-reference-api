using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LungingSpellstrike : Template
    {
        public static readonly Guid ID = Guid.Parse("7e327e43-8b61-4a48-a775-21d04c9a50ed");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Lunging Spellstrike",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0b5fed0c-f72f-4e15-be27-ccfe94e5f988"), Type = TextBlockType.Text, Text = "Your spell unwinds the structure of your staff to make it exceptionally long, or even separate it into shards held together by magical power. Make a (feat: Spellstrike) with a staff, with a spell that isn’t a cantrip or focus spell. Increase the staff’s reach by 5 feet &#215; the spell’s level." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("5c3b803d-4dc9-423a-8f7c-9b5a92d4f2b1"), Feats.Instances.Spellstrike.ID);
            builder.HaveSpecificHybridStudy(Guid.Parse("c3f24f27-12be-4a61-9624-0c3fa24a9ec3"), HybridStudies.Instances.TwistingTree.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d08365e0-5c13-42d2-8f4d-0bb35d5c2ac6"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
