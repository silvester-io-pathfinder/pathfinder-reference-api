using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class LegendaryPerformer : Template
    {
        public static readonly Guid ID = Guid.Parse("b7df072e-3549-446d-af6c-ff78c0e2600b");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Legendary Performer",
                Level = 15,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("a04a50cf-9b36-4dce-8122-5c9e04d80422"), Type = TextBlockType.Text, Text = "Your fame has spread throughout the lands. NPCs who succeed at a DC 10 Society check to (Action: Recall Knowledge) have heard of you and usually have an attitude toward you one step better than normal, depending on your reputation and the NPC’s disposition. For instance, if you’re well-known for cruel and demanding behavior, creatures might be intimidated by you, rather than be friendly toward you. When you (Action: Earn Income) with Performance, you attract higher-level audiences than your location would allow, as audiences flock to see you. For instance, rulers and angels might travel to your small tower in the woods to hear you perform. Typically, this increases the audiences available by 2 levels or more, determined by the GM." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("71084e4b-864e-4d21-9983-a30786ef0920"), Proficiencies.Instances.Legendary.ID, Skills.Instances.Performance.ID);
            builder.HaveSpecificFeat(Guid.Parse("26037759-e688-473d-af52-8cb447857e88"), Feats.Instances.VirtuosicPerformer.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("0513ded8-70b7-4121-b4d9-401fb7bfd266"),
                SourceId = Sources.Instances.CoreRulebook.ID,
                Page = -1
            };
        }
    }
}
