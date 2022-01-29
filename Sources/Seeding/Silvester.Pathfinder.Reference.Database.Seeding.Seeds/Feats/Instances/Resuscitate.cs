using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class Resuscitate : Template
    {
        public static readonly Guid ID = Guid.Parse("c887f813-4405-470b-b0d0-398121cc6eab");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Resuscitate",
                Level = 16,
                ActionTypeId = ActionTypes.Instances.ThreeActions.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("9e38954b-5e53-44d9-b8d0-5917b4dd6012"), Type = TextBlockType.Text, Text = $"You can use Medicine to resuscitate the dead. Attempt a DC 40 Medicine check to revive a dead creature that has been dead for no more than 3 rounds. If you succeed, the target returns to life with the effects of {ToMarkdownLink<Models.Entities.Spell>("raise dead", Spells.Instances.RaiseDead.ID)}, except it still has the wounded condition it had before dying, increased by 1 (or wounded 1 if it wasn't wounded before dying). Whether you succeed or fail, the target is temporarily immune to Resuscitate for 1 day." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("30e5d071-06d0-4c49-a682-045f52f50a12"), Feats.Instances.MedicDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("695cba07-a4b9-449f-ba88-34906a0f0d8d"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Medicine.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("196d257c-e315-48d8-9ce9-408622f0248d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
