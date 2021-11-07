using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class DualFormWeapon : Template
    {
        public static readonly Guid ID = Guid.Parse("dbaea330-014d-4ed9-9638-0f3bb8eb8570");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Dual-Form Weapon",
                Level = 4,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = null,
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("33e3e659-52ae-4bd6-b422-c9cf848c9251"), Type = TextBlockType.Text, Text = "You’ve built your innovation with replaceable interlocking pieces that you can use to transform it into another type of weapon entirely. When you select this feat, choose a level 0 or 1st-level simple or martial weapon. It must be either a common weapon or another to which you have access. This weapon becomes your innovation’s second configuration." };
            yield return new TextBlock { Id = Guid.Parse("c8ad9eff-0be8-491f-99bd-e965c8485aab"), Type = TextBlockType.Text, Text = "Select a new set of weapon modifications for this new configuration. You can spend two (action: Interact) actions to switch your weapon innovation between the two configurations. These actions don’t need to be taken consecutively, but if you’ve provided the first and not the second, the weapon is non-functional as it is stranded between states. Your weapon’s Bulk is always the greater Bulk of the two configurations, regardless of which configuration it’s in—if one weapon is smaller than the other, you still need to keep any weapon parts on hand. Any runes on your weapon innovation don’t affect the second weapon configuration." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificInnovation(Guid.Parse("e5ec4a74-83ae-4c9d-989b-6a1d7d1899de"), Innovations.Instances.Weapon.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("5fc2288a-4996-475a-975a-e6ccee25cd1c"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
