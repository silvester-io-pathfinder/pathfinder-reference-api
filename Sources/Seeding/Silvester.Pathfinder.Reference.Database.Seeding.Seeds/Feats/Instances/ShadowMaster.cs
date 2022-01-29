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
    public class ShadowMaster : Template
    {
        public static readonly Guid ID = Guid.Parse("72621e11-b604-41a9-9f64-526520874f47");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shadow Master",
                Level = 18,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a3ccc59d-4c9e-403c-838d-e6898b22d325"), Type = TextBlockType.Text, Text = $"The shadows protect you better than any armor can, and they give you power to plunge others into darkness. Whenever you are in an area of dim light or darkness, you gain resistance 5 to all damage except force and damage from {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} with the {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("ghost touch", Items.WeaponPropertyRunes.Instances.GhostTouch.ID)} property rune. When you attempt a Reflex saving throw in an area of dim light or darkness, you can roll twice and take the higher result; this is a {ToMarkdownLink<Models.Entities.Trait>("fortune", Traits.Instances.Fortune.ID)} effect." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("85f31130-1797-42bf-ae79-b331195f6e1d"), Feats.Instances.ShadowdancerDedication.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("152677dd-ebca-437a-af44-18c364590f4c"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
