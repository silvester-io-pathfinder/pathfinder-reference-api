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
    public class ButterflysKiss : Template
    {
        public static readonly Guid ID = Guid.Parse("647f394a-45b5-4c15-92fb-fd7cf6e49878");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Butterfly's Kiss",
                Level = 6,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("d6aa43f7-e7f2-4e12-b502-71d0bff3cc1b"), Type = TextBlockType.Text, Text = $"You can make nonlethal {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} with a {ToMarkdownLink<Models.Items.Instances.MeleeWeapon>("butterfly sword", Items.MeleeWeapons.Instances.ButterflySword.ID)} without taking a penalty." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse("479002a3-a2b7-45e9-a10d-ecf092f055b8"), Traits.Instances.Archetype.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("44133912-a242-44b5-861a-1a9c8ddb4851"),
                SourceId = Sources.Instances.FistOfTheRubyPhoenix.ID,
                Page = -1
            };
        }
    }
}
