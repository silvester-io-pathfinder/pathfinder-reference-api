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
    public class RenewingQuills : Template
    {
        public static readonly Guid ID = Guid.Parse("a0ecfbc4-51a3-42da-b1c0-4814cd51665b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Renewing Quills",
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
            yield return new TextBlock { Id = Guid.Parse("414cc8fd-2e99-43a2-9172-3ba8c38541dd"), Type = TextBlockType.Text, Text = $"Your spines grow back much faster than other shisks. You can use the {ToMarkdownLink<Models.Entities.Feat>("Barbed Quills", Feats.Instances.BarbedQuills.ID)} reaction once every 10 minutes." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificHeritage(Guid.Parse("e0f13c3d-2229-41bd-bfcc-3c9b30018b13"), Heritages.Instances.QuillcoatShisk.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Shisk.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("45a85eb3-b042-488d-817f-fa14d1c5c97a"),
                SourceId = Sources.Instances.LostOmensMwangiExpanse.ID,
                Page = -1
            };
        }
    }
}
