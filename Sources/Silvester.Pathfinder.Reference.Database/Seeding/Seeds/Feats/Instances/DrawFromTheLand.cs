using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DrawFromTheLand : Template
    {
        public static readonly Guid ID = Guid.Parse("d306293c-5d94-4a11-a4bb-34ffe51b9bbc");

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
            yield return new TextBlock { Id = Guid.Parse("3cbf8bf4-8daa-4bec-9e8f-1e5f75f9b47d"), Type = TextBlockType.Text, Text = "You pull strength from the surrounding terrain. You gain temporary Hit Points equal to your level. They last for 1 round. If you previously gained the plains terrain attunement effect this turn, combine the temporary Hit Points together." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("c67f482d-66ae-4410-b533-4da76fb90e6a"), Feats.Instances.GeomancerDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("34e90295-473c-460d-9bf6-3649aada986f"), Proficiencies.Instances.Expert.ID, Skills.Instances.Nature.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("829a7fe8-661b-4839-b0fd-141c67e5d6d7"),
                SourceId = Sources.Instances.SecretsOfMagic.ID,
                Page = -1
            };
        }
    }
}
