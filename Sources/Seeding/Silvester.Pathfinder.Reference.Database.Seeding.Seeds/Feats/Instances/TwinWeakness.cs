using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class TwinWeakness : Template
    {
        public static readonly Guid ID = Guid.Parse("2b290660-5f0b-4f4c-a0ce-55e92b6355c6");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Twin Weakness",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.TwoActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("7e8fd507-4144-4d6b-b9b8-9960ef1cc235"), Type = TextBlockType.Text, Text = $"As you make an attack augmented by your esoterica, you also press your implement against the creature to apply its weakness. Make a melee {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)} against the subject of your {ToMarkdownLink<Models.Entities.Feat>("Esoteric Antithesis", Feats.Instances.EsotericAntithesis.ID)}. On any attack roll result but a critical failure, you also press your implement against the creature, applying its weakness from {ToMarkdownLink<Models.Entities.Feat>("Esoteric Antithesis", Feats.Instances.EsotericAntithesis.ID)}. This is in addition to any damage from your {ToMarkdownLink<Models.Entities.Action>("Strike", Actions.Instances.Strike.ID)}, including the weakness it applies. This counts as two attacks when calculating your multiple attack penalty." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("94e34168-da9e-4e52-961e-734c2da59d35"), Feats.Instances.EsotericAntithesis.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("da4f24fe-57e2-4177-8c01-217e945f0e00"),
                SourceId = Sources.Instances.DarkArchive.ID,
                Page = -1
            };
        }
    }
}
