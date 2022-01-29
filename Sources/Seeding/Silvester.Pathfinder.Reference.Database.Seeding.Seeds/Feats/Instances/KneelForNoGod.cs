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
    public class KneelForNoGod : Template
    {
        public static readonly Guid ID = Guid.Parse("f441b303-f098-43db-9f8e-e30d84a857f5");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Kneel For No God",
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
            yield return new TextBlock { Id = Guid.Parse("61a6665c-cd23-443c-ad31-33cd2512c026"), Type = TextBlockType.Text, Text = $"~ Access: Vahird ethnicity" };
            yield return new TextBlock { Id = Guid.Parse("9a698d56-42b5-4d79-8a5c-084ada144110"), Type = TextBlockType.Text, Text = $"Your ancestors' defiance of magic and your people's strictly egalitarian mindset mean that certain forms of magic have little effect on you. When you use your {ToMarkdownLink<Models.Entities.Feat>("Call on Ancient Blood", Feats.Instances.CallOnAncientBlood.ID)} reaction against a divine spell and roll a critical failure on the saving throw against that spell, you get a failure instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("56ae6c94-0a95-46c2-bef6-4542f8839ba2"), Heritages.Instances.AncientBloodedDwarf.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Dwarf.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("e47b8ab6-c3ee-4995-87fd-fee18ab2ca5f"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
