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
    public class AmphibiousForm : Template
    {
        public static readonly Guid ID = Guid.Parse("01ad50e3-4a60-4dd8-8df2-89bc588a6432");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Amphibious Form",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("80dc15b7-02b8-4302-bbac-6dbd6bce1412"), Type = TextBlockType.Text, Text = $"Your eidolon adapts to life on land and underwater. It gains the {ToMarkdownLink<Models.Entities.Trait>("amphibious", Traits.Instances.Amphibious.ID)} trait, allowing it to breathe in water and air and to avoid the normal –2 penalty for making bludgeoning and slashing unarmed Strikes underwater. It gains a swim Speed equal to its land Speed or 25 feet, whichever is less; or if it is normally aquatic, it gains a land Speed equal to its swim Speed or 25 feet, whichever is less." };
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Evolution.ID);
            builder.Add(Guid.Parse(""), Traits.Instances.Summoner.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("17a18729-1505-4779-85e2-fb6151e1c224"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
