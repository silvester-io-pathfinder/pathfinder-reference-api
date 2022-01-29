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
    public class MunitionsMachinist : Template
    {
        public static readonly Guid ID = Guid.Parse("ba5bffd1-450a-4733-976f-c02dc5ea0602");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Munitions Machinist",
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
            yield return new TextBlock { Id = Guid.Parse("170f6f83-bc7a-493e-b28f-2caa17e790e1"), Type = TextBlockType.Text, Text = $"You're particularly adept at crafting ammunition and bombs. Your advanced alchemy level for ammunition and bombs increases to your level – 3." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("0f7f7df0-19f3-4fad-93e5-dd5fef38ca89"), Feats.Instances.MunitionsCrafter.ID);
            builder.HaveSpecificSkillProficiency(Guid.Parse("d1ca6d9c-4bad-4e04-8f8c-479057091003"), Proficiencies.Instances.Expert.ID, Skills.Instances.Crafting.ID);
        }

        protected override void GetTraits(ITraitBindingBuilder<FeatTraitBinding, Feat> builder)
        {
            builder.Add(Guid.Parse(""), Traits.Instances.Gunslinger.ID);

        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("fef54b08-c94e-4312-84e0-3a8e855b75f0"),
                SourceId = Sources.Instances.GunsAndGears.ID,
                Page = -1
            };
        }
    }
}
