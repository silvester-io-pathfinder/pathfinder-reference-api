using Silvester.Pathfinder.Reference.Database.Models.Entities;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Builders;
using Silvester.Pathfinder.Reference.Database.Models.Prerequisites.Instances;
using Silvester.Pathfinder.Reference.Database.Utilities.Text;
using System;
using System.Collections.Generic;

namespace Silvester.Pathfinder.Reference.Database.Seeding.Seeds.Feats.Instances
{
    public class VikingWeaponFamiliarity : Template
    {
        public static readonly Guid ID = Guid.Parse("4abc07de-4d83-4ea6-a343-aa3dbe4ddce3");

        protected override Feat GetFeat()
        {
            return new Feat
            {
                Id = ID,
                Name = "Viking Weapon Familiarity",
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
            yield return new TextBlock { Id = Guid.Parse("0a6e6d6c-6188-469e-ba6a-3adca5f77f34"), Type = TextBlockType.Text, Text = "From childhood, you have been exposed to traditional viking weapons, and you soon learned to handle them in battle. Now, you can raid proudly alongside your fellows. You are trained with the (item: battle axe), (item: hatchet), (item: longsword), and (item: shortsword). In addition, you gain the (feat: Shield Block) reaction." };
        }

        protected override void GetPrerequisites(BooleanPrerequisiteBuilder builder)
        { 
            
            builder.HaveSpecificFeat(Guid.Parse("1cae914f-7ffe-44f5-9027-2d181fe8f60b"), Feats.Instances.VikingDedication.ID);
        }

        protected override IEnumerable<Guid> GetTraits()
        {
            yield break;   
        }            

        protected override SourcePage GetSourcePage()
        {
            return new SourcePage
            {
                Id = Guid.Parse("9c87366f-e008-4754-a567-bd401208afdc"),
                SourceId = Sources.Instances.AdvancedPlayersGuide.ID,
                Page = -1
            };
        }
    }
}
