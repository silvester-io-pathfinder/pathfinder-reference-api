using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class EmeraldBoughsAccustomation : Template
    {
        public static readonly Guid ID = Guid.Parse("9c1c13bb-914c-4f9e-aacd-e95dfa395bbc");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Emerald Boughs Accustomation",
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
            yield return new TextBlock { Id = Guid.Parse("75f57f0f-57e4-4dd2-b362-b77ed0408e0e"), Type = TextBlockType.Text, Text = "You are comfortable and socially capable in almost any cultural context. When you use the Society skill to (action: Subsist | Subsist - Society), if you roll a critical failure, you get a failure instead; if you roll a success, you get a critical success instead; and if you roll a critical success, you can provide for another additional creature. Furthermore, when you attempt a Society check to (action: Recall Knowledge | Recall Knowledge - Society) about cultural practices and roll a critical failure, you get a failure instead." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("40858e5f-9f0e-4408-b4c4-fa6144bf20eb"), Feats.Instances.MagaambyanAttendantDedication.ID);
            builder.Manual(Guid.Parse("6bee1a30-7892-45dd-aafa-c1488661ecdf"), "Emerald Boughs affiliation.");
            builder.HaveSpecificSkillProficiency(Guid.Parse("1a8e79d5-241d-496c-983f-871d1a436560"), Proficiencies.Instances.Expert.ID, Skills.Instances.Society.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("4ba50ed6-6dd8-4a3d-a195-08c17504c598"),
                SourceId = Sources.Instances.LostOmensCharacterGuide.ID,
                Page = -1
            };
        }
    }
}
