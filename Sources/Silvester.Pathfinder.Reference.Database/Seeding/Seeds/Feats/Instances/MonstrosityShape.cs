using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MonstrosityShape : Template
    {
        public static readonly Guid ID = Guid.Parse("e8c4a1e2-ca6e-4159-80c9-78341dd8bc8c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Monstrosity Shape",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("8f623b63-b0e6-4281-b886-c036543a4103"), Type = TextBlockType.Text, Text = "You can transform into a powerful magical creature. Add the purple worm and sea serpent forms listed in (Spell: monstrosity form) to your (Spell: wild shape) list. If you have (Feat: Soaring Shape), add the phoenix form listed in (Spell: aerial form) to your (Spell: wild shape) list." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("47b2a128-4c32-4c82-81f0-98200b046b45"), Feats.Instances.WildShape.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("86b9cf66-8dd9-4aba-b2ae-274b5f57a7d6"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
