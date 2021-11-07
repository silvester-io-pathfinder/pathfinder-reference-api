using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ElectricCounter : Template
    {
        public static readonly Guid ID = Guid.Parse("c0ad8529-5bd3-4cce-8deb-b7b063524a53");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Electric Counter",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "This feat has the trait corresponding to the tradition of ki spells you cast, either divine or occult.",
                Trigger = "You would take damage.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0a61da44-5710-4cd9-b092-57a5d6b562ea"), Type = TextBlockType.Text, Text = "You gain resistance to electricity equal to your level until the start of your next turn. If the triggering damage was electricity, this resistance applies to it. If the triggering damage was from a melee attack, the attacker takes 3d6 electricity damage." };
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("bc793042-ce0a-4485-ab68-0adefc83c670"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
