using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class MedicalResearcher : Template
    {
        public static readonly Guid ID = Guid.Parse("5834f4be-cfd7-4f83-b871-d2dd5f8aa122");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Medical Researcher",
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
            yield return new TextBlock { Id = Guid.Parse("579498ab-5bc3-47e0-ad6e-5926ce343c18"), Type = TextBlockType.Text, Text = "Kassi has taught you not only how to apply medicines with your medical skills but how to craft them as well. When you (action: Craft) (item: healer’s kits | Healer&#39;s Tools), (item: vaccines | Vaccine minor), (item: addiction suppressants | Addiction Suppressant lesser), (item: antidotes | Antidote lesser), (item: antiplagues | Antiplague lesser), (item: elixirs of life | Elixir of Life minor), or other non-magical medical or healing items, you can use Medicine instead of Crafting." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("4f28ba6b-44cd-442d-a4e2-c5db6a57f49a"), Proficiencies.Instances.Trained.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("2782751d-ce9a-4180-bf07-48831848ba4d"),
                SourceId = Sources.Instances.LostOmensLegends.ID,
                Page = -1
            };
        }
    }
}
