using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScroungerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("b4ceec1c-dd14-4ff4-bfb1-ddf9219462c8");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Scrounger Dedication",
                Level = 2,
                ActionTypeId = ActionTypes.Instances.NoAction.ID,
                CanBeLearnedMoreThanOnce = false,
                Special = "You can't select another dedication feat until you have gained two other feats from the scrounger archetype.",
                Trigger = null,
                Frequency = null
            };
        }

        protected override IEnumerable<TextBlock> GetDetailBlocks()
        {
            yield return new TextBlock { Id = Guid.Parse("41363c37-c259-4904-96ab-5886702f6be7"), Type = TextBlockType.Text, Text = "You can (action: Craft) items even without appropriate tools or a workshop, though you take a -2 item penalty to your Crafting check. Additionally, you don’t need a physical formula book to remember all of your formulas; you pay the same cost as normal to learn them, but you memorize them all." };
            yield return new TextBlock { Id = Guid.Parse("be63f0af-c123-49a9-8745-17e857914e71"), Type = TextBlockType.Text, Text = "You can (action: Craft) temporary items out of anything, anywhere, with whatever materials happen to be on hand, spending only 10 minutes to perform the initial Crafting check. The temporary item must be common, non-magical, 1st level or lower, and must be a weapon, armor, or a nonconsumable piece of adventuring gear." };
            yield return new TextBlock { Id = Guid.Parse("d3fea273-bb94-4307-bde4-946304a1dbdb"), Type = TextBlockType.Text, Text = "Instead of a single item, you can create 10 pieces of a single type of ammunition. This is a shoddy item, but you don’t take the normal penalty when using shoddy items you made using this feat. Your temporary item lasts for 1d4 hours before falling apart into its raw components; the GM rolls the number of hours secretly. You can create only the physical item, not any information or magic, so for example, while you could create a blank journal or one of random pages, you couldn’t use it as a (item: scholarly journal) or a (item: religious text)." };
            yield return new TextBlock { Id = Guid.Parse("090590fa-8ce6-4397-8bae-b11775595934"), Type = TextBlockType.Text, Text = "You can incorporate any materials or items that you have on hand, even if they’re not the type of materials that would ordinarily be used to (action: Craft) a given item, though you must have enough volume of material to make the item you want. Unless all the materials you used were an appropriate type to make the item, you take a -5 penalty to the Crafting check (or a -10 penalty if the materials you used were particularly unsuitable, as determined by the GM)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("2f3d7d93-b96e-4c04-8a2d-2a8a7967ea54"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("98d0f8c8-bae8-4887-848c-6b5847fd7650"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
