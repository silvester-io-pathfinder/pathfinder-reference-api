using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class CascadeCountermeasure : Template
    {
        public static readonly Guid ID = Guid.Parse("5f85a5a8-cc59-451f-8ee0-399969f82f1d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Cascade Countermeasure",
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
            yield return new TextBlock { Id = Guid.Parse("3a34089b-9453-4cce-8bae-f7d597efeaea"), Type = TextBlockType.Text, Text = $"When in Arcane Cascade, you can make yourself resistant to magic. You learn the {ToMarkdownLink<Models.Entities.Spell>("cascade countermeasure", Spells.Instances.CascadeCountermeasure.ID)} conflux spell. Increase the number of Focus Points in your focus pool by 1." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("78e10e33-4f2a-47f6-9576-bcca1c30d7d4"), Feats.Instances.ArcaneCascade.ID);
            builder.HaveFocusPool(Guid.Parse("a9812675-6236-49be-816b-b14b5f5c6abc"));
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("1886b237-69c4-49f8-b2a4-86c0f4f64565"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
