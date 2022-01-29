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
    public class IntuitiveIllusions : Template
    {
        public static readonly Guid ID = Guid.Parse("ecbac0e8-40e2-485d-b76b-343c1fee802e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Intuitive Illusions",
                Level = 5,
                ActionTypeId = ActionTypes.Instances.FreeAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "Your turn begins.",
                Frequency = "once per day"
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ec0767e8-342e-4e45-97d8-8f81ad8e1070"), Type = TextBlockType.Text, Text = $"Illusion magic comes to you so naturally that you can effortlessly sustain your magical ruses. You immediately gain the effects of a {ToMarkdownLink<Models.Entities.Action>("Sustain a Spell", Actions.Instances.SustainASpell.ID)} action to extend the duration of one of your active illusion spells." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("31d98e03-9ee4-4f51-afac-f0b876d53748"), Feats.Instances.IllusionSense.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Gnome.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("58ffd9a8-7614-4d3d-bd0a-36804eb6edb1"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
