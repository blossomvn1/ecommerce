package r06.mall.Repositories;
import java.util.Collection;
import java.util.List;

import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import r06.mall.Models.DonHang;

@Repository
public interface OrderRepository extends JpaRepository<DonHang, String> {
    @Query(value = "SELECT * FROM DonHang dh WHERE dh.NguoiGiaoHangNguoiGiaoId = ?1 and dh.TinhTrangGiao = ?2", nativeQuery = true)
    DonHang findDonHangByDriver(String id,Integer tinhtrang);
    @Query(value = "SELECT * FROM DonHang dh WHERE dh.nguoiGiaoHangNguoiGiaoId is null", nativeQuery = true)
    Collection<DonHang> findAllUnpickedOrder();
    
    @Query(value = "select max(YEAR(ThoiGian)) Max, MIN(YEAR(ThoiGian)) Min from DonHang", nativeQuery = true)
    TimeRange findTimeRange();
}

