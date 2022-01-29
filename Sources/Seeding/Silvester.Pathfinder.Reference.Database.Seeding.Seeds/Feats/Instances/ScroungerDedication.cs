using Silvester.Pathfinder.Reference.Database.Seeding.Builders.TextBlocks;
using Silvester.Pathfinder.Reference.Database.Seeding.Builders.Traits;
using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Models.Effects.Enums;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class ScroungerDedication : Template
    {
        public static readonly Guid ID = Guid.Parse("bcedcb92-9e82-4462-8614-804be3e77a47");

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
            yield return new TextBlock { Id = Guid.Parse("51bb987a-c66e-4a73-80ba-13615a03c20a"), Type = TextBlockType.Text, Text = $"You can {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} items even without appropriate tools or a workshop, though you take a -2 item penalty to your Crafting check. Additionally, you don't need a physical formula book to remember all of your formulas; you pay the same cost as normal to learn them, but you memorize them all." };
            yield return new TextBlock { Id = Guid.Parse("8a3f5496-dc7c-400b-a73d-ec7df757a6e9"), Type = TextBlockType.Text, Text = $"You can {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} temporary items out of anything, anywhere, with whatever materials happen to be on hand, spending only 10 minutes to perform the initial Crafting check. The temporary item must be common, non-magical, 1st level or lower, and must be a weapon, armor, or a nonconsumable piece of adventuring gear." };
            yield return new TextBlock { Id = Guid.Parse("44fcbfe4-99c8-4aa8-a0db-b0553c27530b"), Type = TextBlockType.Text, Text = $"Instead of a single item, you can create 10 pieces of a single type of ammunition. This is a shoddy item, but you don't take the normal penalty when using shoddy items you made using this feat. Your temporary item lasts for 1d4 hours before falling apart into its raw components; the GM rolls the number of hours secretly. You can create only the physical item, not any information or magic, so for example, while you could create a blank journal or one of random pages, you couldn't use it as a {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("scholarly journal", Items.AdventuringGears.Instances.ScholarlyJournal.ID)} or a {ToMarkdownLink<Models.Items.Instances.AdventuringGear>("religious text", Items.AdventuringGears.Instances.ReligiousText.ID)}." };
            yield return new TextBlock { Id = Guid.Parse("8197ce09-8efc-4013-a2a1-4692ab840e19"), Type = TextBlockType.Text, Text = $"You can incorporate any materials or items that you have on hand, even if they're not the type of materials that would ordinarily be used to {ToMarkdownLink<Models.Entities.SkillAction>("Craft", SkillActions.Instances.Craft.ID)} a given item, though you must have enough volume of material to make the item you want. Unless all the materials you used were an appropriate type to make the item, you take a -5 penalty to the Crafting check (or a -10 penalty if the materials you used were particularly unsuitable, as determined by the GM)." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("4a537902-25fa-4f3f-88f7-98ab37cc2945"), Proficiencies.Instances.Trained.ID, Skills.Instances.Crafting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("3add1e26-2c7c-4ca1-9d11-5763c68ed34d"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
