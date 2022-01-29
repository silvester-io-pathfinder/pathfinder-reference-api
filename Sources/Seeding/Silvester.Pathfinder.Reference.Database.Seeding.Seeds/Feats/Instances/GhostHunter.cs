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
    public class GhostHunter : Template
    {
        public static readonly Guid ID = Guid.Parse("8933eff5-20eb-43f7-82e0-b089d8466a3e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Ghost Hunter",
                Level = 1,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("fd184d8e-0933-4dda-abc9-647374640906"), Type = TextBlockType.Text, Text = $"Your connection to the Boneyard ensures that your blows strike true against spectral beings. Your weapon and unarmed attack {ToMarkdownLink<Models.Entities.Action>("Strikes", Actions.Instances.Strike.ID)} against incorporeal creatures become magical. If they are already magical, they instead gain the effects of a {ToMarkdownLink<Models.Items.Instances.WeaponPropertyRune>("ghost touch", Items.WeaponPropertyRunes.Instances.GhostTouch.ID)} property rune." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Duskwalker.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("df07e9b1-90c2-4946-82fe-31c566cfd3f7"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
