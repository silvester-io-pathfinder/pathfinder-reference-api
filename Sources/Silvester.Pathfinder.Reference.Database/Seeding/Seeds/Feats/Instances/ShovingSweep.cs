using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ShovingSweep : Template
    {
        public static readonly Guid ID = Guid.Parse("0904a343-68b8-49c1-bc1a-02c70923968e");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Shoving Sweep",
                Level = 8,
                ActionTypeId = ActionTypes.Instances.Reaction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = "A creature within your reach leaves a square during a move action it's using.",
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("009e0674-9001-4f19-b53d-40154423692e"), Type = TextBlockType.Text, Text = "You swing your weapon at your foe, rebuffing them back. You attempt to (action: Shove) the triggering creature, ignoring the requirement that you have a hand free. The creature continues its movement after the (action: Shove)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("38b0e47e-f7c7-47a6-ba65-02c2feb529b5"), Feats.Instances.MaulerDedication.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("ec4d3836-c853-4e3e-aad1-04b901016c87"), Proficiencies.Instances.Expert.ID, Skills.Instances.Athletics.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("6be1b1dd-b210-438a-b3b2-8ce4351489fe"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
