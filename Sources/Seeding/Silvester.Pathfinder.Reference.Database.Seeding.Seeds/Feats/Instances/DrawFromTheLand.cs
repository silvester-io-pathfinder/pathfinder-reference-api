using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DrawFromTheLand : Template
    {
        public static readonly Guid ID = Guid.Parse("37be937c-ef8d-4f34-bc1b-b0dff4441db1");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Draw from the Land",
                Level = 10,
                ActionTypeId = ActionTypes.Instances.OneAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("6fad563e-8904-4bd2-9fe8-46c678100e55"), Type = TextBlockType.Text, Text = $"You pull strength from the surrounding terrain. You gain temporary Hit Points equal to your level. They last for 1 round. If you previously gained the plains terrain attunement effect this turn, combine the temporary Hit Points together." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("4f808128-a6ba-42ca-b7fa-48bab3696e7d"), Feats.Instances.GeomancerDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("6ff0ac56-1e8e-4c73-a889-dea73eb0108a"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("f3d43204-a500-4d3b-b4bd-900f26a3f346"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
