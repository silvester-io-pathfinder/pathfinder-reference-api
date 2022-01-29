using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class UnstoppableJuggernaut : Template
    {
        public static readonly Guid ID = Guid.Parse("9e40dcfd-545d-4f84-855d-3d4f919769c0");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Unstoppable Juggernaut",
                Level = 20,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("476b1924-5af9-4ede-8739-591d48229483"), Type = TextBlockType.Text, Text = $"You have become a brutal, unstoppable force of nature, able to shrug off mortal wounds with ease. You gain resistance equal to 3 + your Constitution modifier to all damage, and your resistance from raging increases to 8 + your Constitution modifier." };
            yield return new TextBlock { Id = Guid.Parse("92a62007-243f-4062-88b6-36286fc5c21a"), Type = TextBlockType.Text, Text = $"In addition, if you are reduced to 0 Hit Points while raging, you can end your rage as a reaction to stay at 1 Hit Point. If you do, you become wounded 2 (or increase your wounded condition by 2 if you are already wounded)." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Barbarian.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("02d6ad6e-a34a-453b-b3a0-d8557623bddc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
