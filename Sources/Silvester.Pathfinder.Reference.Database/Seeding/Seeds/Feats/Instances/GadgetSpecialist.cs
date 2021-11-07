using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class GadgetSpecialist : Template
    {
        public static readonly Guid ID = Guid.Parse("51df1eb7-1921-4836-bd1b-c475fea2752d");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Gadget Specialist",
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
            yield return new TextBlock { Id = Guid.Parse("912259ba-2300-4ff5-ac7f-a8fb7f3197c7"), Type = TextBlockType.Text, Text = "Rather than just using your gadgets for various boosts and tweaks, you also craft a few specific temporary consumable gadgets each day. You gain the formulas for three common or uncommon gadgets (G&amp;G pg. 66). Each day during your daily preparations, you can create two temporary gadgets from your (item: formula book). Gadgets prepared in this way don’t cost you any resources to (action: Craft) and don’t have any sale value. They are temporary items and fall apart the next time you make your daily preparations if you haven’t already used them." };
            yield return new TextBlock { Id = Guid.Parse("0dc5ed77-61d6-4ab0-8c44-fe50cf5dba19"), Type = TextBlockType.Text, Text = "If you’re a master in Crafting, you can create three gadgets per day, and you gain three additional common or uncommon gadget formulas. If you’re legendary in Crafting, you can create four gadgets per day, and you gain another additional three common or uncommon gadget formulas, for a total of nine." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificSkillProficiency(Guid.Parse("2ce1b811-62f0-4fa4-810f-6074df365882"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("afdeca3b-ecd8-4288-8245-00ef3be5a1c5"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
