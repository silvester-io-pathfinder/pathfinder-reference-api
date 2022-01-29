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
    public class EducateAllies : Template
    {
        public static readonly Guid ID = Guid.Parse("641db7df-1306-4352-ae5a-f4acee67274d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Educate Allies",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "An ally benefiting from one of your composition spells is subject to an effect with the auditory, illusion, linguistic, sonic, or visual trait.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("c127a7a5-b7c8-42d9-8cf6-550267314b3d"), Type = TextBlockType.Text, Text = $"You tweak the properties of your composition spell to convey a bit of your defensive knowledge. All allies affected by your composition spell gain your +1 circumstance bonus from {ToMarkdownLink<Models.Entities.Feat>("Well-Versed", Feats.Instances.WellVersed.ID)} until the start of your next turn. Teaching your allies also bolsters your own skills; your personal circumstance bonus from {ToMarkdownLink<Models.Entities.Feat>("Well-Versed", Feats.Instances.WellVersed.ID)} also increases to +2 until the start of your next turn." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1407df5b-323e-4553-a41a-808b5b28144c"), Feats.Instances.WellVersed.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("d7146908-d39d-4696-8f38-9ba30331da6d"), Traits.Instances.Abjuration.ID);
            builder.Add(Guid.Parse("ae946715-de45-4c97-903d-2374b57b5a7c"), Traits.Instances.Bard.ID);
            builder.Add(Guid.Parse("9d44dc79-b5b7-4fcc-adeb-ea4007625e1d"), Traits.Instances.Concentrate.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("cfc66aec-b7b0-45f5-bc28-8a97ad3a14e5"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
