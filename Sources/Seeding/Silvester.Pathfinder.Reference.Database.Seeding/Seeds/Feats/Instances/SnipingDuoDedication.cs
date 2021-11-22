using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class SnipingDuoDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("407a50d1-c324-4e8a-8263-7eda2e73ab56");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Sniping Duo Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you've gained two other feats from the sniping duo archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("ebb9ee6c-2bc8-4b7a-8d24-ec7f6e37893e"), Type = TextBlockType.Text, Text = "When you take this dedication, choose one willing, non-minion ally to act as your spotter. As part of your training in this archetype, you train your spotter in the necessary habits and techniques to use your abilities automatically; your spotter doesn't need to spend any feats of their own to grant the effects. You only gain the benefits of your Sniping Duo archetype feats if both you and your spotter are alive and conscious. You and your spotter don't grant your foes lesser cover against one another's (action: Strikes|Strike). Whenever you or your spotter successfully (action: Strikes|Strike) a target, the other member of your duo gains a +1 circumstance bonus per weapon damage die on the damage roll of their next (action: Strike) made against that target before the end of their next turn." };
            yield return new TextBlock { Id = Guid.Parse("2a9147c0-806b-43a1-8c62-827f576bfa6b"), Type = TextBlockType.Text, Text = "You can change your designated spotter by spending 3 days of downtime training with another ally." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.AddOr(Guid.Parse("c07d3371-370c-45ab-92bb-1169ec0d090d"), or => 
            {
                or.HaveSpecificWeaponGroupSpecificProficiency(Guid.Parse("729b41b3-5546-44bd-b678-e126fd4e6ed8"), Proficiencies.Instances.Trained.ID, WeaponGroups.Instances.Bow.ID);
                or.HaveSpecificWeaponGroupSpecificProficiency(Guid.Parse("26293ce6-9804-4b10-9867-126ea5113630"), Proficiencies.Instances.Trained.ID, WeaponGroups.Instances.Firearm.ID);
            });
            builder.HaveSpecificSkillProficiency(Guid.Parse("77c05912-8167-4228-b32f-a8eac0c05867"), Proficiencies.Instances.Trained.ID, Skills.Instances.Stealth.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("a8219f9a-ac93-4c77-8bea-063f53f94c7f"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
