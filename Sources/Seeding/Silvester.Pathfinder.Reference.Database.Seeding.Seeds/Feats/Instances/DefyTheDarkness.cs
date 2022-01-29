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
    public class DefyTheDarkness : Template
    {
        public static readonly Guid ID = Guid.Parse("ef100636-1fd9-484a-a34b-4c15bb58c317");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Defy the Darkness",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("0b7bde55-fe92-4736-bda4-a5817e24de56"), Type = TextBlockType.Text, Text = $"Using ancient dwarven methods developed to fight enemies wielding magical darkness, you've honed your darkvision and sworn not to use such magic yourself. You gain greater darkvision, enabling you to see through magical darkness even if it normally hampers darkvision (such as the darkness created by a 4th-level {ToMarkdownLink<Models.Entities.Spell>("darkness", Spells.Instances.Darkness.ID)} spell). You can't cast spells with the {ToMarkdownLink<Models.Entities.Trait>("darkness", Traits.Instances.Darkness.ID)} trait, use item activations with the {ToMarkdownLink<Models.Entities.Trait>("darkness", Traits.Instances.Darkness.ID)} trait, or use any other ability with the {ToMarkdownLink<Models.Entities.Trait>("darkness", Traits.Instances.Darkness.ID)} trait." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSense(Guid.Parse("e8fd942b-c9c7-41e2-bdcd-b1d51013aaf9"), Senses.Instances.Darkvision.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Dwarf.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5c5a0fa3-fb3e-47ab-8aef-b6598399d53e"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
