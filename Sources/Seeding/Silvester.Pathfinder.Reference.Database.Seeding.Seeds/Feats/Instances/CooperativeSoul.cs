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
    public class CooperativeSoul : Template
    {
        public static readonly Guid ID = Guid.Parse("6bc8e44f-b764-46c7-a781-5ae0d69f827c");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cooperative Soul",
                Level = 9,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9d03fce7-9406-4d53-83e2-f5f60005162a"), Type = TextBlockType.Text, Text = $"You have developed a soul-deep bond with your comrades and maintain an even greater degree of cooperation with them. If you are at least an expert in the skill you are {ToMarkdownLink<Models.Entities.Action>("Aiding", Actions.Instances.Aid.ID)}, you get a success on any outcome rolled to {ToMarkdownLink<Models.Entities.Action>("Aid", Actions.Instances.Aid.ID)} other than a critical success." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("146679e8-00b8-41bd-a8d6-0e4c12da090d"), Feats.Instances.CooperativeNature.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("12912db7-cb4a-4d89-bed0-813ec8a19fa9"), Traits.Instances.Human.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("d1e5fe2c-c6a3-4838-aeaa-61f88d16cb09"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
